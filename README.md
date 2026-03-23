# apbd-tut3

Design decisions:
Each class has a clear purpose. Equipment, User, and Rental represent the domain model. RentalService handles business logic like rentals, returns, and reports.
Equipment is the base class for Laptop, Projector, and Camera. User is the base class for Student and Employee.
Operations that may fail handled explicitly with checks and early returns.
Program.cs only demonstrates usage and demonstration scenario.

My branches were created locally and were not pushed to git. That is why on git only main branch is shown, but in my project i created two different branches and merged them into main.