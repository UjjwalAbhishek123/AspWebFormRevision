using GridViewBased_CRUD_Project.App_Code.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GridViewBased_CRUD_Project
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if it is not postback, or first load of the page, then bind the gridview
            if (!IsPostBack)
            {
                BindGrid();

                //show message only one time, after any operation (add, update, delete) and then clear the message on page load
                if (Session["Message"] != null)
                {
                    lblMessage.Text = Session["Message"].ToString(); // Display the message stored in session
                    Session["Message"] = null; // Clear the message from session after displaying
                }
                else
                {
                    lblMessage.Text = "";
                }
            }
        }

        public void BindGrid()
        {
            try
            {
                using (ClsEmployee obj = new ClsEmployee())
                {
                    DataSet ds = obj.GetAllEmployees();//return dataset / all employee from database

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        gvEmployee.DataSource = ds.Tables[0]; //bind the first table of dataset to gridview
                        gvEmployee.DataBind(); //bind the data to gridview
                    }
                    else
                    {
                        gvEmployee.DataSource = null; //if no data, set datasource to null
                        gvEmployee.DataBind(); //bind the data to gridview
                    }
                }
            }
            catch (Exception ex)
            {
                //Handle exception as needed
                lblMessage.Text = "Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input controls from the GridView footer row for adding a new employee
                TextBox txtNewName = (TextBox)gvEmployee.FooterRow.FindControl("txtNewName");         // TextBox for entering new employee's name
                TextBox txtNewDepartment = (TextBox)gvEmployee.FooterRow.FindControl("txtNewDepartment"); // TextBox for entering new employee's department
                TextBox txtNewSalary = (TextBox)gvEmployee.FooterRow.FindControl("txtNewSalary");         // TextBox for entering new employee's salary

                if (txtNewName.Text == "" || txtNewDepartment.Text == "" || txtNewSalary.Text == "")
                {
                    Session["Message"] = "Please fill all fields to add a new employee.";
                    lblMessage.ForeColor = System.Drawing.Color.Orange;
                    Response.Redirect("Employee.aspx"); // redirect to same page and show message
                }
                else
                {
                    using (ClsEmployee obj = new ClsEmployee())
                    {
                        //fill properties

                        obj.EmpName = txtNewName.Text.Trim(); // Set the EmpName from the txtNewName TextBox

                        obj.Department = txtNewDepartment.Text.Trim(); // Set the Department from the txtNewDepartment TextBox

                        obj.Salary = Convert.ToDecimal(txtNewSalary.Text.Trim()); // Set the Salary from the txtNewSalary TextBox

                        //call method to insert employee details into database
                        obj.InsertEmployeeDetails();
                    }

                    // Store the success message in session to display after postback
                    Session["Message"] = "Employee Added Successfully";
                    lblMessage.ForeColor = System.Drawing.Color.Green;

                    //BindGrid(); // Refresh the GridView to show the newly added employee

                    Response.Redirect("Employee.aspx"); // redirect to same page and show message, Bind grid too
                }
            }
            catch (Exception ex)
            {
                //Handle exception as needed
                lblMessage.Text = "Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void gvEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEmployee.EditIndex = e.NewEditIndex; // Set the EditIndex of the GridView to the index of the row being edited
            BindGrid(); // Rebind the GridView to reflect the change in edit mode
        }

        protected void gvEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Get the EmployeeID of the row being deleted using DataKeys
                int employeeId = Convert.ToInt32(gvEmployee.DataKeys[e.RowIndex].Value);

                using (ClsEmployee obj = new ClsEmployee())
                {
                    // Set the EmpId property of the ClsEmployee object to the ID of the employee being deleted
                    obj.EmpId = employeeId;

                    // Call the method to delete employee details from the database
                    obj.DeleteEmployeeDetails();
                }
                Session["Message"] = "Employee Deleted Successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                //BindGrid(); // Refresh the GridView to reflect the deletion of the employee

                Response.Redirect("Employee.aspx"); // redirect to same page and show message, Bind grid too
            }

            catch (Exception ex)
            {
                //Handle exception as needed
                lblMessage.Text = "Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void gvEmployee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = gvEmployee.Rows[e.RowIndex];

                // Get the EmployeeID of the row being updated using DataKeys
                int employeeId = Convert.ToInt32(gvEmployee.DataKeys[e.RowIndex].Value);

                TextBox txtEditName = (TextBox)row.FindControl("txtName");
                TextBox txtEditDepartment = (TextBox)row.FindControl("txtDepartment");
                TextBox txtEditSalary = (TextBox)row.FindControl("txtSalary");

                using (ClsEmployee obj = new ClsEmployee())
                {
                    // Set properties of the ClsEmployee object with the updated values from the textboxes
                    obj.EmpId = employeeId;
                    obj.EmpName = txtEditName.Text.Trim();
                    obj.Department = txtEditDepartment.Text.Trim();
                    obj.Salary = Convert.ToDecimal(txtEditSalary.Text.Trim());

                    // Call the method to update employee details in the database and get the updated DataTable
                    DataTable dtUpdated = obj.UpdateEmployeeDetails();

                    if (dtUpdated != null && dtUpdated.Rows.Count > 0)
                    {
                        Session["Message"] = "Employee Updated Successfully";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "No changes were made to update.";
                        lblMessage.ForeColor = System.Drawing.Color.Orange;
                    }
                }
                gvEmployee.EditIndex = -1; // Exit edit mode by resetting EditIndex
                //BindGrid(); // Refresh the GridView to reflect the updated employee details

                Response.Redirect("Employee.aspx"); // redirect to same page and show message, Bind grid too
            }
            catch (Exception ex)
            {
                //Handle exception as needed
                lblMessage.Text = "Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void gvEmployee_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEmployee.EditIndex = -1; // Exit edit mode by resetting EditIndex
            
            //BindGrid(); // Rebind the GridView to reflect the cancellation of edit mode

            Response.Redirect("Employee.aspx"); // redirect to same page and show message, Bind grid too
        }
    }
}