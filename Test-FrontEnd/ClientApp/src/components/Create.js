import React, {useState} from 'react';
import axios from 'axios';



export default function Create(props) {

    const[FirstName, setFirstName] = useState("");
    const[LastName, setLastName] = useState("");
    const[Address, setAddress] = useState("");

    let onSubmit = (e) => {
        e.preventDefault();
    
        const {history} = props;
    
        let student = {
            StudentId: Math.floor(Math.random() * 1000),
            FirstName: FirstName,
            LastName: LastName,
            Address: Address
        };

        console.log(student);
    
        axios.post("https://localhost:5001/api/Test/", student).then(result => {
            history.push('/');
        }).catch(err => console.log(err));
    }
    
    return(
        <div className="trip-form" >
            <h3>Add New Student</h3>
            <form onSubmit={onSubmit}>
                <div className="form-group">
                    <label>Student First Name:  </label>
                    <input 
                        type="text" 
                        className="form-control" 
                        value={FirstName}
                        onChange={ e => setFirstName(e.target.value) }
                        />
                </div>
                <div className="form-group">
                    <label>Student Last Name: </label>
                    <textarea 
            type="text" 
                        className="form-control"
                        value={LastName}
                        onChange={ e => setLastName(e.target.value) }
                    />
                </div>
                <div className="form-group">
                    <label>Student Address:  </label>
                    <input 
                        type="text" 
                        className="form-control" 
                        value={Address}
                        onChange={e => setAddress(e.target.value) }
                        />
                </div>
                
                
                <div className="form-group">
                    <input type="submit" value="Add trip" className="btn btn-primary"/>
                </div>
            </form>
        </div>
    )
}

