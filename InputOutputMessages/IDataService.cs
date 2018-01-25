using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Интерфейс для сервиса доступа к данным.
    /// </summary>
    public interface IDataService
    {

        void AddMessage(InputOutputMessage студент);

        
        //InputOutputMessage GetStudent(string кодЗачетки);

        //void DeleteStudent(string кодЗачетки);

        void ClearMessage();

        IEnumerable<InputOutputMessage> GetAllMessage();

    }
}
