# ASP.NET Login with "Stay Signed In" (Cookies) — Demo

This is a small ASP.NET WebForms project that demonstrates how to:
- implement a login page using cookies (a "Stay Signed In" option), and
- limit failed login attempts (redirect to a failure page after 3 wrong tries) using ViewState + cookies.

It is made to  understand how cookies and simple state handling work in WebForms.

---

## ✅ Files in this project
- `LoginWithStaySignedIn.aspx` / `LoginWithStaySignedIn.aspx.cs`  
  - Main login page. If a cookie exists, it redirects to success page automatically.
  - On login success it creates a cookie. If "Stay Signed In" is checked, cookie expiration is set (1 month).
  - On wrong login attempts it increases a failure counter (ViewState). After 3 fails it writes cookie data and redirects to Failure page.

- `SuccessWithStaySignedIn.aspx` / `SuccessWithStaySignedIn.aspx.cs`  
  - Only accessible when cookie `LoginCookie` exists. Shows welcome message using cookie data.

- `FailureWithStaySignedIn.aspx` / `FailureWithStaySignedIn.aspx.cs`  
  - Displays a message when user failed 3 attempts. Reads the user and count from cookies to show the failure message.

---


1. **Open login page** (`LoginWithStaySignedIn.aspx`).
2. If a login cookie named `LoginCookie` exists, the page **directly redirects** to the Success page.
3. If no cookie exists, user must enter username and password:
   - If credentials match (e.g. `admin`/`admin` in this demo), a cookie named `LoginCookie` is created:
     - `cookie["User"] = txtUser.Text;`
     - `cookie["Pwd"] = txtPwd.Text;`
     - If **Stay Signed In** is checked, cookie expiry is set to **1 month**.
     - User is redirected to `SuccessWithStaySignedIn.aspx`.
   - If credentials are wrong:
     - The code increases a failure counter stored in `ViewState["FailureCount"]`.
     - When `FailureCount == 3`, the username and count are saved to cookies (`User` and `Count`) and user is redirected to the `FailureWithStaySignedIn.aspx` page.
4. `SuccessWithStaySignedIn.aspx` checks for `LoginCookie`. If missing, it redirects back to login.
5. `FailureWithStaySignedIn.aspx` reads `User` and `Count` cookies and displays the failure message. If those cookies are missing, it redirects to login.
schreenshorts
1.<img width="1920" height="972" alt="1" src="https://github.com/user-attachments/assets/3ab00207-6e60-4db3-8fdd-45bf69dabe8f" />
2.<img width="1920" height="972" alt="2" src="https://github.com/user-attachments/assets/e98331c2-7de1-4c0f-ac7c-04378c9c19f9" />
3.<img width="1920" height="972" alt="3" src="https://github.com/user-attachments/assets/25d42b56-f51e-4e00-803d-dc7501e04cad" />
4.<img width="1920" height="972" alt="4" src="https://github.com/user-attachments/assets/626764fb-84ff-487b-bac1-4743e8bf00a9" />
5.<img width="1920" height="972" alt="5" src="https://github.com/user-attachments/assets/36edc99f-de11-4fd3-9e34-feea1b2333ab" />
6.<img width="1920" height="972" alt="cookies" src="https://github.com/user-attachments/assets/a45b73a4-d742-449d-97a9-ef03209c8a1c" />






    txtUser.Focus();
}
