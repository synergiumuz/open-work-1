﻿using System;

namespace OpenWork.Services.Dtos.Workers;

public class BusynessSearchDto
{
	public long WorkerId { get; set; }

	public DateOnly FromDate { get; set; }
	public DateOnly ToDate { get; set; }

	public TimeOnly FromTime { get; set; }
	public TimeOnly ToTime { get; set; }
}
