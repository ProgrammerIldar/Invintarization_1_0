//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inv.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seizure
    {
        public int SeizureID { get; set; }
        public System.DateTime DataSeizure { get; set; }
        public int CatrigeID { get; set; }
    
        public virtual Catriges Catriges { get; set; }
    }
}
