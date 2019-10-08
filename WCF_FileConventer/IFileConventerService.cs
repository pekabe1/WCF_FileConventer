using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_FileConventer
{

    [ServiceContract]
    public interface IFileConventerService
    {

        [OperationContract]
        FileModel ConvertToCSV(FileModel file);

        [OperationContract]
        FileModel GetDataUsingDataContract(FileModel composite);
        // TODO: Add your service operations here
    }

    [DataContract] // model
    public class FileModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Content { get; set; }
    }
}
