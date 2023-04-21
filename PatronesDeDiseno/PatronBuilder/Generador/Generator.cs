﻿using System.Text.Json;

namespace PatronesDeDiseno.PatronBuilder.Generador
{
    public class Generator
    {
        public List<string>? Content { get; set; }
        public string Path { get; set; } = string.Empty;
        public TypeFormat Format { get; set; }
        public TypeCharacter Character { get; set; }

        public void Save()
        {
            string result = "";
            result = Format == TypeFormat.Json ? GetJson() : GetPipe();
            if (Character == TypeCharacter.Uppercase) result = result.ToUpper();
            if (Character == TypeCharacter.Lowercase) result = result.ToLower();

            File.WriteAllText(Path, result);
        }

        private string GetJson() => JsonSerializer.Serialize(Content);

        private string GetPipe() => Content.Aggregate((acumulador, current) => acumulador + "|" + current);
    }
}
