import { setState } from "react";
import React from "react";
import '../styles/FormLogin.css'
import {URL} from "../pages/URL";
import { useState } from "react";

class FormLogin extends React.Component  {



	state={
		form:{
			"User":"",
			"Password":""
		}
	}
	handlerSubmit =e=>{
		e.preventDefault();
	}
	handlerChange = async e =>{
		await this.setState({
			form:{
				...this.state.form,
				[e.target.name] : e.target.value
			}
		})
		console.log(this.state.form)
	}
	handlerButton =async e => {
		await this.setState({
			form:{
				...this.state.form,
				[e.target.name] : e.target.value
			}
		})
		
	}
	render() {
		return(
			<React.Fragment>
            <div className="container">
    

    <div className="omb_login">

		<div className="row omb_row-sm-offset-3">
			<div className="col-xs-12 col-sm-6">	
			    <form onSubmit={this.handlerSubmit} className="omb_loginForm" action="" autocomplete="off" method="POST">
					<div className="input-group">
						<span className="input-group-addon"><i className="fa fa-user"></i></span>
						<input type="text" className="form-control" name="User" placeholder="email address" onChange={this.handlerChange} />
					</div>
					<span className="help-block"></span>
										
					<div className="input-group">
						<span className="input-group-addon"><i className="fa fa-lock"></i></span>
						<input  type="password" className="form-control" name="Password" placeholder="Password" onChange={this.handlerChange}/>
					</div>
                    <div><h1></h1></div>
					
				</form>
				
			</div>
			<div class="d-grid gap-2 col-6 mx-auto">
				<br/>
				<button class="btn btn-primary" onClick={this.handlerButton} type="submit">Button</button>
				
			</div>
			
    	</div>
		
		<div className="row omb_row-sm-offset-3">
			<div className="col-xs-12 col-sm-3">
				<label className="checkbox">
					<input type="checkbox" value="remember-me"/>Remember Me
				</label>
			</div>
			<div className="col-xs-12 col-sm-3">
				<p className="omb_forgotPwd">
					<a href="#">Forgot password?</a>
				</p>
			</div>
		</div>	    	
	</div>



        </div>
            </React.Fragment>
		)
	}

}
export default FormLogin
