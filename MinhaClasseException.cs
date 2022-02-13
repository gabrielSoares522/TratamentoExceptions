using System.Runtime.Serialization;

namespace TratamentoExceptions
{
    [Serializable]
    public class MinhaClasseException:Exception
    {
        public MinhaClasseException(){

        }

        public MinhaClasseException(string? message):base(message){
            
        }
        
        public MinhaClasseException(string? message, Exception? innerException): base(message,innerException){
            
        }
        
        protected MinhaClasseException(SerializationInfo info, StreamingContext context):base(info,context){
            
        }

        public string? MinhaPropriedade;
    }
}