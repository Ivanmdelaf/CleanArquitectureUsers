using System;
using System.Collections.Generic;
using System.Text;

namespace UserManager.Application.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
