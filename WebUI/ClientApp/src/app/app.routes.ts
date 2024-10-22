import { Routes } from '@angular/router';
import { GenerationComponent } from './generation/generation.component';

export const routes: Routes = [
    { path: "generation",  component: GenerationComponent },

    { path: "*",  component: GenerationComponent },

    { path: "", redirectTo: "generation", pathMatch: "full" }, // Перенаправление на главную страницу
    { path: "**", redirectTo: "generation", pathMatch: "full" }, // Перенаправление на страницу 404
];
