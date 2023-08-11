import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environments';
import { Producto } from '../interfaces/producto.interface';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
  })
  export class ServiciosService {

    productos : Producto []= [];

    constructor(private httpClient : HttpClient) { }

    getProductos() {
        return this.httpClient.get<Producto[]>(`${environment.apiUrl}/Productos/list`);
      }
      
        
  iniciarSesion(correo: string, contraseña: string): Observable<any> {
    const url = `${environment.apiUrl}/usuarios`;
    const body = { correo: correo, contrasena: contraseña };
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

    return this.httpClient.post(url, body, { headers: headers });
  }
  
  }