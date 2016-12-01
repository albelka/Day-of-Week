# Find day of week


#### By **Anne Belka, Steve Burton**

### Specifications

These are the steps I'll take to write my code:


Separate first two digits of year from last two digits.
* Input: 2010
* Output: 20 10

If month is January or February subtract 1 from the last two digits of year.
* Input: January 2016
* Output: January 2015


Shift month back by two
* Input: February = 2
* Output: February = 12

Assign numbers to days of week
* Input: Saturday
* Output: 6

Apply formula w = (d +[2.6m-0.2] + y [y/4] + [c/4]-2c) mod 7;
* Input: 1/1/2000
* Output: Saturday


## Setup/Installation Requirements

* Clone this repository or download it to your computer.
* Navigate to the project directory in the terminal.
* Use the command > dnu restore to download any necessary dependencies.
* Use the command > dnx kestrel to run the project on the local server.
* Navigate to localhost:5004 in your browser to view the app



### License

GPL

Copyright (c) 2016 **_Anne Belka, Steve Burton_**
