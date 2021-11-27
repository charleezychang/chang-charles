import './App.css';



function App(props) {
  function deleteHandler() {
    alert("asdasd");
    }

  return (
    <div className='card'>
      <h2>{props.text}</h2>
      <div className='actions'>
        <button className='btn' onClick={deleteHandler}>Delete</button>
      </div>
    </div>
  );
}

export default App;
