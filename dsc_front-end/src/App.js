import "./App.css";
import { BrowserRouter, Routes, Route } from "react-router-dom";

// import  from "./components/Layout";
import Home from "./containers/Home/Homepage";
import Login from "./containers/Login/Login";
import SignUp from "./containers/SignUp/SignUp";
import ResetPassword from "./containers/ResetPassword";
import UserAbout from "./containers/UserAbout/UserAbout";
import { ProtectRoutes } from "./hooks/ProtectRoutes";
import AppProvider from "./hooks";
// import MyCalendar from "./components/MyCalendar";
import MyProfile from "./containers/MyProfile/Profile";
// import Admin from "./containers/Admin";
import Header from "./components/Header/Hearder";
// import EventDetail from "./containers/EventDetail";
// import NewBooking from "./components/NewBooking";
// import Payment from "./containers/Payment";
// import News from "./components/News/News";
// import CustomerUnpaidList from "./containers/CustomerUnpaidList";
// import BookingDetail from "./containers/NotificationDetail/BookingDetail";
// import { ChangePass } from "./containers/ChangePassword/ChangePass";
// import Contract from "./components/NewBooking/Contract";

function App() {
  return (
    <BrowserRouter>
      <AppProvider>
        <Routes>
          <Route index element={<Home />} />
          <Route path="login" element={<Login />} />
          <Route path="signup" element={<SignUp />} />
          <Route path="reset-password" element={<ResetPassword />} />
          <Route path="my-profile" element={<MyProfile />} />
          <Route element={<ProtectRoutes />}>
            <Route path="user-about" element={<UserAbout />} />
            
            {/* <Route
              path="user-my-calendar"
              element={(<MyCalendar />)}
            /> */}
            {/* <Route
              path="event-detail"
              element={(<EventDetail />)}
            />
            <Route
              path="user-my-calendar/new-booking"
              element={(<NewBooking />)}
            /> */}
            {/* <Route path="news/:id" element={(<News />)} /> */}
            {/* <Route
              path="user-my-calendar/new-booking/payment/:companyNameForPayment"
              element={(<Payment />)}
            /> */}
            
            {/* <Route
              path="change-pass"
              element={(<ChangePass />)}
            />
            <Route
              path="booking-detail/:bookingName"
              element={(<BookingDetail />)}
            />
            <Route
              path="customer-unpaid-list"
              element={(<CustomerUnpaidList />)}
            />
            <Route path="admin" element={<Admin />} />
            <Route path="contract/:bookingName" element={<Contract />} /> */}
          </Route>
        </Routes>
      </AppProvider>
    </BrowserRouter>
  );
}

export default App;
