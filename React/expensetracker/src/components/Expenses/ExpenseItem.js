import React, { useState } from 'react';

import './ExpenseItem.css';
import ExpenseDate from './ExpenseDate';
import Card from '../UI/Card';

function ExpenseItem(props) {
    // let title = props.title;
    
    const [title, setTitle] = useState(props.title); //a react hook, called in main component function, accepts 'initial state' as a parameter
    //returns an array, the first value is the value itself, the second value is the function to change that value
    //if you call the component multiple times, each of these will have its own state, aka they are independent of each other
    //why const when were assigning a new value? theres no new value, react works behind the scenes 

    function clickHandler() {
        // title = 'Updated!';
        // line 8 and 15 wont work because react doesnt re-"load" the component tree
        setTitle("Hello"); //will change the value AND the component function is re-executed
    }

    return (
        <Card className='expense-item'>            
        {/* essentially you made your own div with pre-defined styles. */}
        {/* custom tags dont have an attribute of className, so YOU MUST DECLARE THEM IN YOUR TAG'S JS FILE */}
            <ExpenseDate date={props.date}/>
            <div className='expense-item__description'>
                <h2>{title}</h2>
                <div className='expense-item__price'>{props.amount}</div>
            </div>
            <button onClick={clickHandler}>Change Title</button>          
        {/* Its important to know that you just "POINT" to the handler and not execute it aka not like: onClick={clickHandler()} */}
        {/* with the parenthesis, the function will be executed upon loading the button */}
        {/* you can create (arrow) functions in the event listener if the function can be done in few codes: () => {enter code here} or function () {}*/}
        </Card>
    );
}

export default ExpenseItem