import React from "react";

import Header from "./Header";
function SideMenu() {
  const handleProfile = (path) => {
    window.location.href = path;
  };
  return (
    <>
      <Header />
      <br></br>
      <div
        style={{
          display: "flex",
          justifyContent: "center",
          alignItems: "center",
        }}
      >
        <div style={{ padding: "10px" }}>
          <button
            onClick={() => handleProfile("/profile")}
            className="btn btn-primary"
          >
            My Profile
          </button>
        </div>
        <div style={{ padding: "10px" }}>
          <button
            onClick={() => handleProfile("/myorders")}
            className="btn btn-primary"
          >
            My Orders
          </button>
        </div>
        <div style={{ padding: "10px" }}>
          <button
            onClick={() => handleProfile("/products")}
            className="btn btn-primary"
          >
            All Products
          </button>
        </div>
        <div style={{ padding: "10px" }}>
          <button
            onClick={() => handleProfile("/cart")}
            className="btn btn-primary"
          >
            Cart
          </button>
        </div>
      </div>
      <br></br>
      <br></br>
      <div
        style={{
          display: "flex",
          justifyContent: "center",
          alignItems: "center",
        }}
      >
        <div style={{ padding: "10px" }}>
          <h2>Welcome to E-Medicine</h2>
        </div>
      </div>
    </>
  );
}

export default SideMenu;
