﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ventas.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
	

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IEnumerable<WeatherForecast> Get()
		{
			List<WeatherForecast> lst = new List<WeatherForecast>();

			lst.Add(new WeatherForecast() { id = 5, nombre = "Sebastian" });
			lst.Add(new WeatherForecast() { id = 6, nombre = "juan" });




			return lst;
		}
	}
}
