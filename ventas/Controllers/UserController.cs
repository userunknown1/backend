﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ventas.Models.Request;
using ventas.Models.Response;
using ventas.Services;

namespace ventas.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpPost("login")]
		public IActionResult Autentificar([FromBody] AuthRequest model) 
		{
			Respuesta respuesta = new Respuesta();

			
			var userresponse = _userService.Auth(model);

			if (userresponse == null)
			{
				respuesta.Exito = 0;
				respuesta.Mensaje = "Usuario o Contraseña incorrecto";
				return BadRequest(respuesta);
			}

			respuesta.Exito = 1;
			respuesta.Data = userresponse;
			return Ok(respuesta);
			 
		
		}
	}
}
