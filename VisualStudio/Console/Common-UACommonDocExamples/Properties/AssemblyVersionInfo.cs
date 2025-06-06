// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved. 									

using System.Reflection;
using OpcLabs.BaseLib.Reflection;
using UACommonDocExamples.Properties;

#pragma warning disable 0436 																							
#if !NO_CUSTOM_REFERENCES 																								
[assembly: AssemblyBranch(AssemblyProperties.AssemblyBranch)] 															
#endif 																												
[assembly: AssemblyVersion(AssemblyProperties.AssemblyVersion)] 														
[assembly: AssemblyFileVersion(AssemblyProperties.AssemblyFileVersion)] 												
#pragma warning restore 0436 																							
 																														
// ReSharper disable CheckNamespace 																					
// ReSharper disable PartialTypeWithSinglePart 																		
namespace UACommonDocExamples.Properties
{
    static partial class AssemblyProperties 																				
// ReSharper restore PartialTypeWithSinglePart 																		
// ReSharper restore CheckNamespace 																					
    { 																														
        public const string AssemblyBranch = "2024.2"; 																	
        public const string AssemblyVersion = "5.81.0.7"; 														
        public const string AssemblyFileVersion = "5.81.0.7"; 													
    }
} 																														
