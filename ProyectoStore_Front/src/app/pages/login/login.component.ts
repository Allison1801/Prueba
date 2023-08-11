import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ServiciosService } from '../services/servicios.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginForm!: FormGroup;
  submitted = false;

  constructor(private formBuilder: FormBuilder, private loginService:ServiciosService, private router: Router) { }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.required]
    });
  }

  onSubmit() {
    this.submitted = true;
    if (this.loginForm.invalid) {
      return;
    }


    const email = this.loginForm.value.email;
    const password = this.loginForm.value.password;

    this.loginService.iniciarSesion(email, password).subscribe(
      (data) => {
        
        console.log(data);
        this.router.navigateByUrl("")
      },
      (error) => {
        
        console.error(error);
        this.limpiarFormulario()
      
      }
    );
  }
  limpiarFormulario(){
    this.loginForm.reset();
  }

  
}
