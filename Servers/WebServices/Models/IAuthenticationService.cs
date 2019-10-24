using System.ServiceModel;
using System.Threading.Tasks;

namespace Models
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        string Ping(string s);

        [OperationContract]
        AuthenticationResponse PingComplexModel(AuthenticationInput inputModel);

        [OperationContract]
        void VoidMethod(out string s);

        [OperationContract]
        Task<int> AsyncMethod();

        [OperationContract]
        int? NullableMethod(bool? arg);
    }
}