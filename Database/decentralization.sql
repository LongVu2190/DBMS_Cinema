Customer
CREATE ROLE Customer
GRANT SELECT ON Fn_BookedSeats TO Customer
GRANT SELECT ON Fn_CustomerLogin TO Customer
GRANT SELECT ON Fn_MovieRating TO Customer
GRANT SELECT ON Fn_ShowTimeByActor TO Customer
GRANT SELECT ON Fn_ShowTimeByCompany TO Customer
GRANT SELECT ON Fn_ShowTimeByScreen TO Customer
GRANT SELECT ON Fn_SumTotalCost TO Customer
GRANT SELECT ON Fn_UserBooked TO Customer
GRANT SELECT ON Fn_UserCommented TO Customer
GRANT SELECT ON Fn_UserInformation TO Customer
GRANT SELECT ON Movie TO Customer
GRANT SELECT ON ShowTime TO Customer
GRANT INSERT ON Reservation TO Customer
GRANT SELECT ON Reservation TO Customer
GRANT UPDATE ON Reservation TO Customer
GRANT INSERT ON Review TO Customer
GRANT SELECT ON Review TO Customer
GRANT UPDATE ON Review TO Customer
GRANT SELECT ON View_Comments TO Customer
GRANT SELECT ON View_ShowingInDay TO Customer
GRANT SELECT ON View_ComingShowing TO Customer
GRANT INSERT ON Customer TO Customer
GRANT SELECT ON Customer TO Customer
GRANT UPDATE ON Customer TO Customer
GRANT SELECT ON Room TO Customer
GRANT SELECT ON Company TO Customer
GRANT INSERT ON User_Information TO Customer
GRANT SELECT ON User_Information TO Customer
GRANT UPDATE ON User_Information TO Customer
GRANT EXECUTE ON Sp_AddNewCustomer TO Customer
GRANT EXECUTE ON Sp_AddOrUpdateComment TO Customer
GRANT EXECUTE ON Sp_AddReservation TO Customer

Login
CREATE ROLE Login
GRANT SELECT ON Fn_AdminLogin TO Login
GRANT SELECT ON Fn_CustomerLogin TO Login
GRANT SELECT ON Customer TO Login
GRANT SELECT ON Admin TO Login
GRANT SELECT ON User_Information TO Login
GRANT EXECUTE ON Sp_AddNewCustomer TO Login

Admin
CREATE ROLE Admin
GRANT SELECT ON Fn_AdminLogin TO Admin
GRANT SELECT ON Fn_MovieRating TO Admin
GRANT SELECT ON Fn_ShowTimeByActor TO Admin
GRANT SELECT ON Fn_ShowTimeByCompany TO Admin
GRANT SELECT ON Fn_ShowTimeByScreen TO Admin
GRANT SELECT ON Fn_UserCommented TO Admin
GRANT SELECT ON Fn_UserInformation TO Admin
GRANT DELETE ON Movie TO Admin
GRANT INSERT ON Movie TO Admin
GRANT SELECT ON Movie TO Admin
GRANT UPDATE ON Movie TO Admin
GRANT DELETE ON ShowTime TO Admin
GRANT INSERT ON ShowTime TO Admin
GRANT SELECT ON ShowTime TO Admin
GRANT UPDATE ON ShowTime TO Admin
GRANT DELETE ON Reservation TO Admin
GRANT INSERT ON Reservation TO Admin
GRANT SELECT ON Reservation TO Admin
GRANT UPDATE ON Reservation TO Admin
GRANT DELETE ON Review TO Admin
GRANT INSERT ON Review TO Admin
GRANT SELECT ON Review TO Admin
GRANT UPDATE ON Review TO Admin
GRANT SELECT ON View_Comments TO Admin
GRANT SELECT ON View_ShowingInDay TO Admin
GRANT SELECT ON View_ComingShowing TO Admin
GRANT DELETE ON Customer TO Admin
GRANT INSERT ON Customer TO Admin
GRANT SELECT ON Customer TO Admin
GRANT UPDATE ON Customer TO Admin
GRANT SELECT ON View_isVIP TO Admin
GRANT SELECT ON View_isNotVIP TO Admin
GRANT SELECT ON View_ClosedShowing TO Admin
GRANT DELETE ON Room TO Admin
GRANT INSERT ON Room TO Admin
GRANT SELECT ON Room TO Admin
GRANT UPDATE ON Room TO Admin
GRANT SELECT ON View_ShowingInDayAvailable TO Admin
GRANT SELECT ON View_ShowingInDayOut TO Admin
GRANT SELECT ON View_HighRatingShowing TO Admin
GRANT DELETE ON Admin TO Admin
GRANT INSERT ON Admin TO Admin
GRANT SELECT ON Admin TO Admin
GRANT UPDATE ON Admin TO Admin
GRANT DELETE ON Company TO Admin
GRANT INSERT ON Company TO Admin
GRANT SELECT ON Company TO Admin
GRANT UPDATE ON Company TO Admin
GRANT DELETE ON User_Information TO Admin
GRANT INSERT ON User_Information TO Admin
GRANT SELECT ON User_Information TO Admin
GRANT UPDATE ON User_Information TO Admin
GRANT EXECUTE ON Sp_AddNewCompany TO Admin
GRANT EXECUTE ON Sp_AddNewCustomer TO Admin
GRANT EXECUTE ON Sp_AddNewMovie TO Admin
GRANT EXECUTE ON Sp_AddNewRoom TO Admin
GRANT EXECUTE ON Sp_AddNewShowTime TO Admin
GRANT EXECUTE ON Sp_AddReservation TO Admin
GRANT EXECUTE ON Sp_DelReservation TO Admin