﻿namespace Konu12KalitimInheritance
{
    public class Kategori : OrtakOzellikler
    {
        public string KategoriyeOzelTanitim {  get; set; }
        public bool UstMenudeGoster { get; set; }
        public bool YanMenudeGoster { get; set; }
        public bool AltMenudeGoster { get; set; }
    }
}
