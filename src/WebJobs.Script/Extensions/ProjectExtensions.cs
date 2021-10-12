// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using System.Xml.Linq;
using static Microsoft.Azure.WebJobs.Script.ScriptConstants;

namespace Microsoft.Azure.WebJobs.Script.BindingExtensions
{
    internal static class ProjectExtensions
    {
        internal const string ExtensionsProjectSdkAttributeName = "Sdk";
        internal const string ExtensionsProjectSdkPackageId = "Microsoft.NET.Sdk";
        internal const string ProjectElementName = "Project";
        internal const string TargetFrameworkElementName = "TargetFramework";
        internal const string PropertyGroupElementName = "PropertyGroup";
        internal const string WarningsAsErrorsElementName = "WarningsAsErrors";
        internal const string TargetFrameworkNetStandard2 = "netstandard2.0";

        public static void CreateProject(this XDocument document)
        {
            XElement project =
                new XElement(ProjectElementName,
                    new XAttribute(ExtensionsProjectSdkAttributeName, ExtensionsProjectSdkPackageId),
                    new XElement(PropertyGroupElementName,
                        new XElement(WarningsAsErrorsElementName),
                        new XElement(TargetFrameworkElementName, new XText(TargetFrameworkNetStandard2))),
                    new XElement(ItemGroupElementName));

            document.AddFirst(project);
        }

        public static void AddPackageReference(this XDocument document, string packageId, string version)
        {
            XElement existingPackageReference = document.Descendants()?.FirstOrDefault(
                                                        item =>
                                                        item?.Name == PackageReferenceElementName &&
                                                        item?.Attribute(PackageReferenceIncludeElementName).Value == packageId);

            if (existingPackageReference != null)
            {
                // If the package with the same version is already present, move on...
                if (existingPackageReference.Attribute(PackageReferenceVersionElementName)?.Value == version)
                {
                    return;
                }

                existingPackageReference.Remove();
            }

            document.CreatePackageReference(packageId, version);
        }

        public static void RemovePackageReference(this XDocument document, string packageId)
        {
            XElement existingPackageReference = document.Descendants()?.FirstOrDefault(
                                                        item =>
                                                        item?.Name == PackageReferenceElementName &&
                                                        item?.Attribute(PackageReferenceIncludeElementName).Value == packageId);
            if (existingPackageReference != null)
            {
                existingPackageReference.Remove();
            }
        }

        internal static void CreatePackageReference(this XDocument document, string id, string version)
        {
            XElement group = document.GetUniformItemGroupOrNew(PackageReferenceElementName);
            XElement element = new XElement(PackageReferenceElementName,
                                    new XAttribute(PackageReferenceIncludeElementName, id),
                                    new XAttribute(PackageReferenceVersionElementName, version));
            group.Add(element);
        }

        internal static XElement GetUniformItemGroupOrNew(this XDocument document, string itemName)
        {
            XElement group = document.Descendants(ItemGroupElementName).FirstOrDefault(g => g.Elements().All(i => i.Name.LocalName == itemName));

            if (group == null)
            {
                document.Root.Add(new XElement(ItemGroupElementName));
                group = document.Descendants(ItemGroupElementName).LastOrDefault();
            }

            return group;
        }
    }
}
