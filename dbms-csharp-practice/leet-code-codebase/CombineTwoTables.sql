/* Write your T-SQL query statement below */
select firstName,lastName,city,state
from Person  AS p
left join Address AS a
on a.personId=p.personId