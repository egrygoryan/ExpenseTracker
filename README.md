# ExpenseTracker

An opportunity to track your money expenses

**Used stack:**
- Backend
  - C#
  - ASP.NET Core Web App (MVC)
  - Entity Framework Core
- DB
  - Microsoft SQL Server
- Frontend
  - Javascript
  - HTML
  - CSS
  
**The app provides the following functionality:**
- Initialise a budget with different currency
- Withdraw/add from/to a budget
- Choose an expense type
- Create a separate budget for your savings
- Add tags and comments to your records
- Simultaneous work for several users on a budget
- See your records for a certain period 
- Export your expenses into convenient formats (not decided yet which one)

<ins>**Case 1**</ins>

User manually set up budget with custom currency ($, €, ₴) filling in it with some expenses. 
Additionally another user is able to provide his payment records with different categories (health, grocceries, etc.)
Both of them can look through all of the record.

<ins>**Case 2**</ins>

User creates balance which can be used as an saving account, with periodic replenishment of the account. 
Records contains detailed info such as date, note or sum.
