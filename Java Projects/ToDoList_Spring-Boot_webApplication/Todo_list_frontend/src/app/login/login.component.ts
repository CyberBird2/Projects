import {Component, Input, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {AuthService} from '../Service/auth.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username = '';
  password = '';
  invalidLogin = false;
  errorMessage = 'Invalid Credentials';
  successMessage: string;
  loginSuccess = false;

  @Input() error: string | null;
  showSpinner: any;

  constructor(private router: Router, private  authService: AuthService) { }

  ngOnInit(): void {
  }

  checkLogin() {
    (this.authService.authenticate(this.username, this.password).subscribe(
        data => {
          this.router.navigate(['']);
          this.invalidLogin = false;
          this.loginSuccess = true;
          this.successMessage = 'Login Successful.';
        },
        error => {
          this.invalidLogin = true;
          this.error = error.message;
          this.loginSuccess = false;

        }
      )
    );

  }
}
