import { useState } from 'react';
import Modal from './Modal';
import Backdrop from './Backdrop';

function Todo(props) {
    const [modalIsOpen, setModalIsOpen] = useState(false)  //react hooks can only be called directly in a react component function
    //useState returns an array with 2 elements
    //[state, setstate] is javascript array destructuring

    function deleteHandler() {
        setModalIsOpen(true)
    }

    function closeModalHandler() {
        setModalIsOpen(false)
    }
  
    return (
      <div className='card'>
        <h2>{props.text}</h2>
        <div className='actions'>
          <button className='btn' onClick={deleteHandler}>Delete</button>
        </div>
        { modalIsOpen? <Modal onCancel={closeModalHandler} onConfirm={closeModalHandler}/> : null }
        {/* {modalIsOpen && <Modal/>}  same as line20, if both is true, it returns the 2nd value */}
        {modalIsOpen && <Backdrop onCancel={closeModalHandler}/>}

      </div>

      
    );
  }
export default Todo;