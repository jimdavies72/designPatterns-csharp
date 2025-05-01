using System;
using System.Net;

namespace structuralDesignPatterns.src.Proxy;

public class YouTubeVideo : IVideo
{
  private string _videoId;

  public YouTubeVideo(string videoId)
  {
    _videoId = videoId;
    Download();
  }

  private void Download()
  {
    Console.WriteLine($"Downloading video with ID: {_videoId} from YouTube API");
  }

  public void Render()
  {
    Console.WriteLine($"Rendering video with ID: {_videoId}");
  }

  public string GetVideoId()
  {
    return _videoId;
  }
}