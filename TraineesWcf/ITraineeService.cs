using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TraineesWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITraineeService" in both code and config file together.
    [ServiceContract]
    public interface ITraineeService
    {
        [OperationContract]
        List<Trainees> GetTrainee();

        [OperationContract]
        List<Trainees> AddTraniee(Trainees addNewTraine);

        [OperationContract]
        List<Trainees> UpdateTrainee(Trainees updatedTrainee);

        [OperationContract]
        List<Trainees> DeleteTrainee(int deletedTraineeId);
    }

    [DataContract]
    public class Trainees
    {
        [DataMember]
        public int TraineeId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }
    }
} 
