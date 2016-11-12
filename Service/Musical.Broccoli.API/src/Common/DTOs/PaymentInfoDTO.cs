﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class PaymentInfoDTO
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public int TypeOfCard { get; set; }
        public string CardHolderName { get; set; }
        public int ExpirationDate { get; set; }
        public int UserId { get; set; }

        public UserDTO User { get; set; }
    }
}
