## Assessment

Create a small full stack solution to do tax calculations using .NET Core using MVC Razor (please do not use a front end framework such as Angular as takes too long to get the projects running) and doing some basic CRUD
operations on SQL Server (must provide localdb with assignment). Publish your assessment to your GitHub account and please include all build instructions to get your solution running.

### A few pointers:

* Latest .NET Core version is preferred
* Make sure you understand how progressive tax works
* Besides completing the test and getting it to work, and accuracy is important, it is also a chance to show the senior developers your understanding of a good framework so
    * Adhere to the SOLID principals
    * Unit tests
    * Avoid scaffolding
    * Clean well-formatted code

### Task brief:

You have been briefed to write a tax calculator for an individual. The application will take annual income and postal code.

**Each postal code is linked to a type of Tax calculation:**

| Postal Code | Tax Calculation Type |
|-------------|----------------------|
| 7441        | Progressive          |
| A100        | Flat Value           |
| 7000        | Flat rate            |
| 1000        | Progressive          |

**The progressive tax is calculated based on this table (be sure you understand how a progressive calculation works):**

| Rate | From   | To     | 
|------|--------|--------|
| 10%  | 0      | 8350   |
| 15%  | 8351   | 33950  |    
| 25%  | 33951  | 82250  |                      
| 28%  | 82251  | 171550 |  
| 33%  | 171551 | 372950 | 
| 35%  | 372951 | 0      |


**The flat value:**
* 10000 per year
* Else if the individual earns less than 200000 per year the tax will be at 5%
 
**The flat rate:**
* All users pay 17.5% tax on their income

**Approach:**
* Write a tax calculator using TDD
* Use SOLID principals
* Preferred testing framework is Nunit using full or core framework
* Razor frontend
* ORM of choice
* Use of Design Patterns preferable
* IOC/Dependency Injection
* Allow for entering the Postal code and annual income on the front end and submitting
* Store the calculated value to SQL Server with date/time and the two fields entered
* Security is not required but feel free to show off
* Server side should be REST API’s