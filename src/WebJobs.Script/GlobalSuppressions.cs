﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Code Analysis results, point to "Suppress Message", and click
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.BindingMetadata.#Type")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.ParameterDescriptor.#Type")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.PackageManager.#RestorePackagesAsync()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionDescriptorProvider.#ParseManualTrigger(Microsoft.Azure.WebJobs.Script.Description.BindingMetadata,System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionInvokerBase.#InitializeFileWatcherIfEnabled()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Binding.HttpBinding.#BindAsync(Microsoft.Azure.WebJobs.Script.Binding.BindingContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Binding.FunctionBinding.#ConvertStreamToValue(System.IO.Stream,Microsoft.Azure.WebJobs.Script.Description.DataType,System.Object&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1007:UseGenericsWhereAppropriate", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Binding.FunctionBinding.#ConvertStreamToValue(System.IO.Stream,Microsoft.Azure.WebJobs.Script.Description.DataType,System.Object&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.DotNetFunctionDescriptorProvider.#CreateFunctionInvoker(System.String,Microsoft.Azure.WebJobs.Script.Description.BindingMetadata,Microsoft.Azure.WebJobs.Script.Description.FunctionMetadata,System.Collections.ObjectModel.Collection`1<Microsoft.Azure.WebJobs.Script.Binding.FunctionBinding>,System.Collections.ObjectModel.Collection`1<Microsoft.Azure.WebJobs.Script.Binding.FunctionBinding>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.BindingMetadata.#Raw")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Binding.BindingContext.#Attributes")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "refkind", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionParameter.#.ctor(System.String,System.String,System.Boolean,Microsoft.CodeAnalysis.RefKind)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Binding.ManualTriggerAttributeBindingProvider+ManualTriggerBinding.#CreateListenerAsync(Microsoft.Azure.WebJobs.Host.Listeners.ListenerFactoryContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sku", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.EnvironmentSettingNames.#AzureWebsiteSku")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "IDictionary", Scope = "type", Target = "Microsoft.Azure.WebJobs.Script.IDictionaryExtensions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptHost.#SettingsManager")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptHost.#SettingsManager")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Config.ScriptSettingsManager.#GetSetting(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Config.ScriptSettingsManager.#SetSetting(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionLoader`1.#.ctor(System.Func`2<System.Threading.CancellationToken,System.Threading.Tasks.Task`1<!0>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionLoader`1.#Reset()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "2#", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.IDictionaryExtensions.#TryGetValue`1(System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.String,!!0&,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_fileWatcher", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionInvokerBase.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_debugModeFileWatcher", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptHost.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_scriptFileWatcher", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptHost.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.IO.AutoRecoveringFileSystemWatcher.#InitializeWatcher()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sku", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptConstants.#DynamicSku")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sku", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Config.ScriptSettingsManager.#IsDynamicSku")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1203:Constants must appear before fields", Justification = "<Pending>", Scope = "member", Target = "~F:Microsoft.Azure.WebJobs.Script.ScriptConstants.HttpMethodConstraintName")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1636:File header copyright text must match", Justification = "<Pending>")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name must match first type name", Justification = "<Pending>", Scope = "type", Target = "~T:Microsoft.Azure.WebJobs.Script.Diagnostics.HostStarted")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1314:Type parameter names must begin with T", Justification = "<Pending>", Scope = "type", Target = "~T:Microsoft.Azure.WebJobs.Script.Description.FunctionLoader`1.FunctionValueLoader`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionDescriptor.#InputBindings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Description.FunctionDescriptor.#OutputBindings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_fileEventSource", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptHost.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sku", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptConstants.#DynamicSkuConnectionLimit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Extensibility.ScriptBindingContext.#Type")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sku", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptConstants.#DynamicSkuConnectionLimit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_traceWriter", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.Diagnostics.StructuredLogWriter.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptHost.#GetDirectTypes(System.Collections.Generic.IEnumerable`1<Microsoft.Azure.WebJobs.Script.Description.FunctionMetadata>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_functionDispatcher", Scope = "member", Target = "Microsoft.Azure.WebJobs.Script.ScriptHost.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "<Pending>", Scope = "member", Target = "~F:Microsoft.Azure.WebJobs.Script.Description.DotNetConstants.FrameworkReferences")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1019:Member access symbols should be spaced correctly", Justification = "<Pending>", Scope = "member", Target = "~M:Microsoft.Azure.WebJobs.Script.Description.DotNet.DotNetMuxer.TryFindMuxerPath~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1307:Accessible fields should begin with upper-case letter", Justification = "<Pending>", Scope = "member", Target = "~F:Microsoft.Azure.WebJobs.Script.Workers.SECURITY_ATTRIBUTES.lpSecurityDescriptor")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<Pending>", Scope = "type", Target = "~T:Microsoft.Azure.WebJobs.Script.Workers.JobObjectInfoType")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1307:Accessible fields should begin with upper-case letter", Justification = "<Pending>", Scope = "member", Target = "~F:Microsoft.Azure.WebJobs.Script.Workers.SECURITY_ATTRIBUTES.nLength")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1307:Accessible fields should begin with upper-case letter", Justification = "<Pending>", Scope = "member", Target = "~F:Microsoft.Azure.WebJobs.Script.Workers.SECURITY_ATTRIBUTES.bInheritHandle")]