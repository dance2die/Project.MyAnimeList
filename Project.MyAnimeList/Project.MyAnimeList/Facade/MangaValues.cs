using System;
using MyAnimeListSharp.Enums;

namespace MyAnimeListSharp.Facade
{
	public class MangaValues : MyAnimeListValues
	{
		private int _chapter;
		private int _volume;
		private int _downloadedChapters;
		private int _timesReread;
		private int _retailVolumes;

		public int Chapter
		{
			get { return _chapter; }
			set
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException("Chapter", "Chapter value cannot be negative");
				_chapter = value;
			}
		}

		public int Volume
		{
			get { return _volume; }
			set
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException("Volume", "Volume value cannot be negative");
				_volume = value;
			}
		}

		public MangaStatus MangaStatus { get; set; }

		public int DownloadedChapters
		{
			get { return _downloadedChapters; }
			set
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException("DownloadedChapters", "DownloadedChapters value cannot be negative");
				_downloadedChapters = value;
			}
		}

		public int TimesReread
		{
			get { return _timesReread; }
			set
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException("RereadCount", "TimesReread value cannot be negative");

				// 255 is the value that is set when the value is set to above 255 on MyAnimeList.net
				if (value > 255)
					throw new ArgumentOutOfRangeException("RereadCount", "TimesReread value should be less than or equal to 255");
				_timesReread = value;
			}
		}

		public string ScanGroup { get; set; }

		public int RetailVolumes
		{
			get { return _retailVolumes; }
			set
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException("RetailVolumes", "RetailVolumes value cannot be negative");
				_retailVolumes = value;
			}
		}
	}
}