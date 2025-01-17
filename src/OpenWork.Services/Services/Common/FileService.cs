﻿using System.IO;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

using OpenWork.Domain.Common.Helpers;
using OpenWork.Services.Interfaces.Common;

namespace OpenWork.Services.Services.Common
{
	public class FileService : IFileService
	{
		private readonly string images = "images";

		private readonly string _rootpath;
		public FileService(IHostingEnvironment webHostEnvironment)
		{
			_rootpath = webHostEnvironment.WebRootPath;
		}

		public async Task<string> SaveImageAsync(IFormFile image)
		{
			string imageName = ImageHelper.MakeImageName(image.FileName);

			string imagePath = Path.Combine(_rootpath, images, imageName);
			FileStream stream = new FileStream(imagePath, FileMode.Create);
			try
			{
				await image.CopyToAsync(stream);
				return Path.Combine(images, imageName);
			}
			catch
			{
				return "";
			}
			finally
			{
				stream.Close();
			}
		}
	}
}
