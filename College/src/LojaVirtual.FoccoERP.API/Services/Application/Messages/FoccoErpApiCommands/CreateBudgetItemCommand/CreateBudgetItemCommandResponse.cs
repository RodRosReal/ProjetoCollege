﻿using Domain.ValueObjects;
using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class CreateBudgetItemCommandResponse 
	{
        [DataMember]
        public CreateBudgetItemResponse CreateBudgetItemResponse { get; set; }
    } 
}
