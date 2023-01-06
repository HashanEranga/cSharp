using System;
namespace OOP.Classes.typesofclasses.Sealed
{
    public sealed class Mobile
    {
        public int nextId = 0;
        public int modelId;
        public string? ModelName { get; set; }
        public string? ModelDescription { get; set; }

        public Mobile(string modelName, string modelDescription)
        {
            modelId = ++nextId;
            ModelName = modelName;
            ModelDescription = modelDescription;
        }

        public override string ToString()
        {
            return $"Model Id : {modelId}, Model Name : {ModelName}, Model Description : {ModelDescription}";
        }
    }
}

