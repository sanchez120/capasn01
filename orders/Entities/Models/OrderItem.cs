<<<<<<< HEAD
﻿using EntitiesAL.Models;
using EntitiesL.Models;
using System;
=======
﻿using System;
>>>>>>> d17191366650dea143d501228ed0d4253f067612
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("OrderItem")]
//[Index("OrderId", Name = "IndexOrderItemOrderId")]
//[Index("ProductId", Name = "IndexOrderItemProductId")]
public partial class OrderItem
{
    [Key]
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderItems")]
    public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("OrderItems")]
    public virtual Product Product { get; set; } = null!;
}
