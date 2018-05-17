using Rock_Paper_Scissor.Library;

namespace Rock_Paper_Scissor.Interfaces
{
    public interface IPlayer
    {
        Enums.Move LastMove { get; set; }

        Enums.Move PlayNextMove();
    }
}
