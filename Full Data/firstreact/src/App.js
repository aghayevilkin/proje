import Header from "./header";
import { useState } from "react";

function App() {
  const [name, setName] = useState("Guest");

  function login() {
    setName("Ilkin");
  }
  return (
    <div className="container">
      <Header title={name} />
      <h4>User App</h4>
      <hr />
      <button onClick={login}>Login</button>
    </div>
  );
}

export default App;
