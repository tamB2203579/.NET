using blazorapp2.Data;

public class StaffRepository:IStaffRepository{
    public StaffsContext context;
    public StaffRepository(StaffsContext context){
        this.context = context;
    }
    public async Task<Employee> GetStaff(int id ){
        return (from employee in context.Employees
                where employee.EmployeeId == id
                select employee).First();
    }
    public async Task<IEnumerable<Employee>> GetAllStaffs(){
        return context.Employees;
    }
}