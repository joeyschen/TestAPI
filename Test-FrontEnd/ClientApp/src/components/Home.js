import React, { useState, useEffect } from 'react';
import axios from 'axios';
import {Link} from 'react-router-dom'

export default function Home (props){
    const [student, setStudent] = useState([]);
    const [error, setError] = useState(false);
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        setLoading(true);
        axios.get("https://localhost:5001/api/Test/").then(result => {
          const response = result.data;
          console.log(response);
          setStudent(response);
          setLoading(false);
      }).catch(err => {
          setError(true);
          setLoading(false);
      });
    }, []);

    return (
        loading ? <div>Loading...</div> : error ? <div>Error occured.</div> : 

        <div>
            <Link to="/create">
                <button type="button">+Create Student</button>
            </Link>

            <h1>Student List: </h1>

            
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Address</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        student.map((stu, i) => (
                          <tr key={i}>
                              <td>{stu.firstName}</td>
                              <td>{stu.lastName}</td>
                              <td>{stu.address}</td>
                          </tr>
                        ))
                    }
                </tbody>
            </table>
        </div>
    );
}