using System;
using System.Collections.Generic;

namespace ContactCRUD.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }
}
