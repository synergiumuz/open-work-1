﻿using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using OpenWork.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWork.Domain.Entities
{
	public class Category : BaseEntity
	{
		public string Name { get; set; } = string.Empty;
		public virtual IList<Sphere> Spheres { get; set; } = new List<Sphere>();
	}
}
