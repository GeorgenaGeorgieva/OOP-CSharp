﻿namespace HighQualityMistakes
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType($"HighQualityMistakes.{investigatedClass}");
            FieldInfo[] classFileds = classType.GetFields(
                BindingFlags.Instance 
                | BindingFlags.Static 
                | BindingFlags.NonPublic 
                | BindingFlags.Public);

            StringBuilder stringBuilder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFileds.Where(f => requestedFields.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public string AnalyzeAcessModifiers(string investigatedClass)
        {

            Type classType = Type.GetType($"HighQualityMistakes.{investigatedClass}");
           
            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance |
                BindingFlags.Static | 
                BindingFlags.Public);

            MethodInfo[] publicMethods = classType.GetMethods(
                BindingFlags.Instance | 
                BindingFlags.Public);

            MethodInfo[] nonPublicMethods = classType.GetMethods(
                BindingFlags.Instance |
                BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach  (FieldInfo field in classFields)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to public!");
            }

            foreach (MethodInfo method in publicMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be private!");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
