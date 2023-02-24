public class Activity
{
    // activityNum 1 = BreathingActivity, 2 = ReflectingActivity, 3 = ListingActivity
    private string _activityNum;
    private string _startMessage;
    private string _duration;

    public Activity(string activityNum, string startMessage, string duration)
    {
        _activityNum = activityNum;
        _startMessage = startMessage;
        _duration = duration;
    }


}