//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoYshakoffnick
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bookings
    {
        public int booking_id { get; set; }
        public Nullable<System.DateTime> booking_date { get; set; }
        public Nullable<int> equipment_id { get; set; }
        public Nullable<int> training_type_id { get; set; }
        public Nullable<int> member_id { get; set; }
        public Nullable<int> status_id { get; set; }
        public Nullable<int> trainer_id { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual Members Members { get; set; }
        public virtual BookingStatus BookingStatus { get; set; }
        public virtual Trainers Trainers { get; set; }
        public virtual TrainingTypes TrainingTypes { get; set; }
    }
}
