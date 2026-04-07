using System.Threading.Tasks;

namespace Loop.PersonalLogger;

public interface IExternalNotifier
{
    Task NotifyAsync(string message);
}