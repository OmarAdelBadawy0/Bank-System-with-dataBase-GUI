using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Bank_system
{
    internal class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private DataTable DataTabledt;


        public Functions()
        {

            con = new SqlConnection("Data Source=.;Initial Catalog=BankSystem;Integrated Security=True");
            con.Open();
        }

        ~Functions()
        {
            con.Close();
        }

        public void AddUser(string name, int SSN, int phone, string adress, string password)
        {
            cmd = new SqlCommand("insert into customer(name,SSN, phone, address, password) values(@n,@s,@p,@a,@pass)", con);
            cmd.Parameters.AddWithValue("n", name);
            cmd.Parameters.AddWithValue("s", SSN);
            cmd.Parameters.AddWithValue("p", phone);
            cmd.Parameters.AddWithValue("a", adress);
            cmd.Parameters.AddWithValue("pass", password);
            cmd.ExecuteNonQuery();
        }

        public void AddAdmin(int AdminCode, string UserName, string password)
        {
            cmd = new SqlCommand("insert into admin(Admin_Code, Username, password) values(@a,@u,@p)", con);
            cmd.Parameters.AddWithValue("a", AdminCode);
            cmd.Parameters.AddWithValue("u", UserName);
            cmd.Parameters.AddWithValue("p", password);
            cmd.ExecuteNonQuery();
        }

        public void AddEmployee(int EmployeeCode, string name, string position, string password)
        {
            cmd = new SqlCommand("insert into employer(empid, name, position, password) values(@e,@n,@po,@p)", con);
            cmd.Parameters.AddWithValue("e", EmployeeCode);
            cmd.Parameters.AddWithValue("n", name);
            cmd.Parameters.AddWithValue("p", password);
            cmd.Parameters.AddWithValue("po", position);
            cmd.ExecuteNonQuery();
        }

        public void UpdateCustomer(string name, int phone, string adress, string password, int curSSN)
        {
            try
            {
                cmd = new SqlCommand("Update customer set name = @n, phone = @p, address = @a, password = @pass where ssn = @ssn", con);
                cmd.Parameters.AddWithValue("n", name);
                cmd.Parameters.AddWithValue("p", phone);
                cmd.Parameters.AddWithValue("a", adress);
                cmd.Parameters.AddWithValue("pass", password);
                cmd.Parameters.AddWithValue("ssn", curSSN);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfuly");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool loginCustomer(int SSN, string password)
        {
            
                cmd = new SqlCommand("select * from customer where ssn = @s and password = @p", con);
                cmd.Parameters.AddWithValue("s", SSN);
                cmd.Parameters.AddWithValue("p", password);
                SqlDataAdapter da= new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successfuly");
                    return true;
                }
                else
                {
                    MessageBox.Show("SSN or password is incorrect!!");
                    return false;
                }
        }

        public bool LoginEmp(int Empid, string password)
        {
            cmd = new SqlCommand("select * from employer where empid = @s and password = @p", con);
            cmd.Parameters.AddWithValue("s", Empid);
            cmd.Parameters.AddWithValue("p", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successfuly");
                return true;
            }
            else
            {
                MessageBox.Show("EMP ID or password is incorrect!!");
                return false;
            }
        }

        public bool LoginAdmin(int Adminid, string password)
        {
            cmd = new SqlCommand("select * from admin where admin_code = @s and password = @p", con);
            cmd.Parameters.AddWithValue("s", Adminid);
            cmd.Parameters.AddWithValue("p", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successfuly");
                return true;
            }
            else
            {
                MessageBox.Show("Admin ID or password is incorrect!!");
                return false;
            }
        }

        public void showAdminPage(int id)
        {
            
            cmd = new SqlCommand("select admin_code, username from admin where admin_code = @code", con);

            cmd.Parameters.AddWithValue("code", id);

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                //Admin_page adminPage = new Admin_page(id);
        
            }

        }

        public void AddBank(string name, string address, int bankCode, int adminCode)
        {
            cmd = new SqlCommand("insert into bank(name, address, bank_code, admin_code) values(@n,@a,@b,@ad)", con);
            cmd.Parameters.AddWithValue("n", name);
            cmd.Parameters.AddWithValue("a", address);
            cmd.Parameters.AddWithValue("b", bankCode);
            cmd.Parameters.AddWithValue("ad", adminCode);
            cmd.ExecuteNonQuery();
        }

       public void AddBranch(int branch, int bank, string address, int adminCode)
        {
            cmd = new SqlCommand("insert into branch(branch_number, bank_code, address, admin_code) values(@br,@ba,@a,@ad)", con);
            cmd.Parameters.AddWithValue("br", branch);
            cmd.Parameters.AddWithValue("a", address);
            cmd.Parameters.AddWithValue("ba", bank);
            cmd.Parameters.AddWithValue("ad", adminCode);
            cmd.ExecuteNonQuery();
        }

        public bool customerIsExist(int ssn)
        {
            cmd = new SqlCommand("select * from customer where ssn = @s", con);
            cmd.Parameters.AddWithValue("s", ssn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Customer found");
                return true;
            }
            else
            {
                MessageBox.Show("SSN is incorrect!!");
                return false;
            }
        }

        public void AddAccount(int accountNum ,int ssn, int balance, string accountType)
        {
            cmd = new SqlCommand("insert into account(account_num, ssn, balance,acount_type) values(@n,@s,@b,@t)", con);
            cmd.Parameters.AddWithValue("n", accountNum);
            cmd.Parameters.AddWithValue("s", ssn);
            cmd.Parameters.AddWithValue("b", balance);
            cmd.Parameters.AddWithValue("t", accountType);
            cmd.ExecuteNonQuery();
        }

        public void ViewLoans(DataGridView dataGridView1)
        {
            try
            {
            cmd = new SqlCommand("select * from loan", con);
            cmd.ExecuteNonQuery();
            DataTable dataTable= new DataTable();
            SqlDataAdapter da =new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource= dataTable;
            }catch(Exception ex) { }
        }

        public void Viewcustomer(DataGridView dataGridView1)
        {
            try
            {
                cmd = new SqlCommand("select * from customer", con);
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex) { }
        }

        public void Viewloancustomeremp(DataGridView dataGridView1)
        {
            try
            {
                cmd = new SqlCommand("SELECT L.*, C.name as Customer_Name, E.NAME as Employee_Name\r\nFROM LOAN AS L \r\nJOIN CUSTOMER AS C ON L.SSN = C.SSN\r\nJOIN EMPLOYER as E ON E.EMPID = L.EMPID", con);
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex) { }
        }

        public void RequestLoan(int loan, int amount, int branch, string type)
        {
            try
            {

                cmd = new SqlCommand("insert into loan(loan_num,branch_number,loan_amount,loan_type) values(@n,@b,@a,@t)",con);
                cmd.Parameters.AddWithValue("n", loan);
                cmd.Parameters.AddWithValue("b", branch);
                cmd.Parameters.AddWithValue("a", amount);
                cmd.Parameters.AddWithValue("t", type);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The loan is requested :)");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ViewLoansControl(DataGridView dataGridView1)
        {
            try
            {
                cmd = new SqlCommand("select * from loan where Status = 'pending'", con);
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex) { }
        }

        public void changeLoanStatus(int loanNum ,string newStatus)
        {
            if(newStatus == "accept")
            {
                cmd = new SqlCommand("Update LOAN\r\nSET Status = @s\r\nWHERE LOAN_NUM =@l ", con);
                cmd.Parameters.AddWithValue("l", loanNum);
                cmd.Parameters.AddWithValue("s", newStatus);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand("delete from loan where loan_num = @l", con);
                cmd.Parameters.AddWithValue("l", loanNum);
                cmd.ExecuteNonQuery();
            }

        }

        public int getBalance(int SSN)
        {
            cmd = new SqlCommand("select balance from account where ssn = @s", con);
            cmd.Parameters.AddWithValue("s", SSN);
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            // dataTable.Rows[]["2"];
            return 1;
        }



    }
}
