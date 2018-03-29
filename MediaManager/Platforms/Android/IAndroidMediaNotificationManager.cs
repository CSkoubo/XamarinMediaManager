using Android.App;
using Android.Support.V4.Media.Session;
using Plugin.MediaManager.Abstractions;

namespace Plugin.MediaManager
{
    public interface IAndroidMediaNotificationManager : IMediaNotificationManager
    {
        IMediaQueue MediaQueue { get; set; }
        MediaSessionCompat.Token SessionToken { get; set; }
        Notification Notification { get; }
        int NotificationId { get; }
    }
}