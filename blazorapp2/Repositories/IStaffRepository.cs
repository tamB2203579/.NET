using blazorapp2.Data;

public interface IStaffRepository{
    Task <IEnumerable<Employee>> GetAllStaffs();
    Task <Employee> GetStaff(int id);
}