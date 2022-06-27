
using TransferMoney.Domain.DTO.Input;

namespace TransferMoney.Provider
{
    public class TransferMoneyProvider : ITransferMoneyProvider
    {

        object ITransferMoneyProvider.TransferMoneyRequest(TransferMoneyInput request)
        {
            switch (request.SourceCardNumber.Substring(6))
            {
                case "123456":
                    AyandeConnector ayandeConnector = new AyandeConnector();
                    return ayandeConnector.TransferMoney(request);
                    break;
                case "134555":
                    SamanConnector samanConnector = new SamanConnector();
                    return samanConnector.TransferMoney(request);
                    break;
                case "234546":
                    MellatConnector mellatConnector = new MellatConnector();
                    return mellatConnector.TransferMoney(request);
                    break;
                default:
                    return null;
            }
        }
    }
}