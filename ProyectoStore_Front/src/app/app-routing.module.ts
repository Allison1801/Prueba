import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';
import { ProductosComponent } from './pages/productos/productos.component';
import { CarritoComponent } from './pages/carrito/carrito.component';

const routes: Routes = [

  {
    path:"login",
    component:LoginComponent,
    pathMatch:'full',
  },
  {
    path:"",
    component:ProductosComponent,
    pathMatch:'full',
  },
  {
    path:"carrito",
    component:CarritoComponent,
    pathMatch:'full',
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
