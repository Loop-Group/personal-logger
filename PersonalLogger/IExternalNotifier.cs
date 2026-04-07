using System.Threading.Tasks;

namespace LuxuzDev.PersonalLogger;

public interface IExternalNotifier
{
    Task NotifyAsync(string message);
}