// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using System.Xml.Linq;
using static Microsoft.Azure.WebJobs.Script.ScriptConstants;

namespace Microsoft.Azure.WebJobs.Script.BindingExtensions
{
    internal static class ProjectExtensions
    {
        private const string ExtensionsProjectSdkAttributeName = "Sdk";
        private const string ExtensionsProjectSdkPackageId = "Microsoft.NET.Sdk";
        private const string ProjectElementName = "Project";
        private const string TargetFrameworkElementName = "TargetFramework";
        private const string PropertyGroupElementName = "PropertyGroup";
        private const string WarningsAsErrorsElementName = "WarningsAsErrors";

        public static void CreateProject(this XDocument document)
        {
            XElement project =
                new XElement(ProjectElementName,
                    new XAttribute(ExtensionsProjectSdkAttributeName, ExtensionsProjectSdkPackageId),
                    new XElement(PropertyGroupElementName,
                        new XElement(WarningsAsErrorsElementName)),
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

        public static void AddTargetFramework(this XDocument document, string innerText)
        {
            XElement existingPackageReference = document.Descendants()?.FirstOrDefault(
                                                        item =>
                                                        item?.Name == TargetFrameworkElementName &&
                                                        item?.Value == innerText);

            if (existingPackageReference != null)
            {
                return;
            }

            document.CreateTargetFramework(innerText);
        }

        public static void RemoveTargetFramework(this XDocument document, string innerText)
        {
            XElement existingPackageReference = document.Descendants()?.FirstOrDefault(
                                                        item =>
                                                        item?.Name == TargetFrameworkElementName &&
                                                        item?.Value == innerText);

            if (existingPackageReference != null)
            {
                existingPackageReference.Remove();
            }
        }

        internal static void CreateTargetFramework(this XDocument document, string innerText)
        {
            if (document.Root.Element(PropertyGroupElementName) == null)
            {
                document.Root.Add(new XElement(PropertyGroupElementName));
            }

            XElement element = new XElement(TargetFrameworkElementName, new XText(innerText));
            document.Root.Element(PropertyGroupElementName).Add(element);
        }

        internal static void CreatePackageReference(this XDocument document, string id, string version)
        {
            if (document.Root.Element(ItemGroupElementName) == null)
            {
                document.Root.Add(new XElement(ItemGroupElementName));
            }

            XElement element = new XElement(PackageReferenceElementName,
                                    new XAttribute(PackageReferenceIncludeElementName, id),
                                    new XAttribute(PackageReferenceVersionElementName, version));
            document.Root.Element(ItemGroupElementName).Add(element);
        }
    }
}
