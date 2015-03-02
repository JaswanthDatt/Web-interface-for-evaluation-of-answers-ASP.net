using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    // TODO: Add your service operations here
    [OperationContract]
    student FindById(int id);

    [OperationContract]
    bool Create(student s);

    [OperationContract]
    bool UpdateById(student s);

    [OperationContract]
    bool DeleteById(int id);

    [OperationContract]
    IList<student> ReadAll();
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.

[DataContract]
public class student
{
    int student_id;
    string Firstname;
    string Lastname;
    string MI;
    string MaleFemale;
    DateTime BirthDate;
    DateTime DateAdded;
    // Id (Can be auto field) 
    [DataMember]
    public int Student_id
    {
        get { return student_id; }
        set { student_id = value; }
    }

    [DataMember]
    public string fname
    {
        get { return Firstname; }
        set { Firstname = value; }
    }
    [DataMember]
    public string lname
    {
        get { return Lastname; }
        set { Lastname = value; }
    }
    [DataMember]

    public string mi
    {
        get { return MI; }
        set { MI = value; }
    }
    [DataMember]
    public string male_female
    {
        get { return MaleFemale; }
        set { MaleFemale = value; }
    }

    [DataMember]
    public DateTime birth_Date
    {
        get { return BirthDate; }
        set { BirthDate = value; }
    }
    [DataMember]
    public DateTime date_Added
    {
        get { return DateAdded; }
        set { DateAdded = value; }
    }
}
