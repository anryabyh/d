//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demotme
{
    using System;
    using System.Collections.Generic;
    
    public partial class Struct_order
    {
        public int id { get; set; }
        public int id_order { get; set; }
        public Nullable<int> id_products { get; set; }
        public Nullable<short> colvo { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
    }
}
