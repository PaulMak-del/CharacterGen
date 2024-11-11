import { Routes } from '@angular/router';
import { GenerationComponent } from './generation/generation.component';
import { CharacterCreateComponent } from './character-create/character-create.component';

export const routes: Routes = [
    { path: "generation",  component: GenerationComponent },
    { path: "character-create",  component: CharacterCreateComponent},

    { path: "*",  component: GenerationComponent },

    { path: "", redirectTo: "generation", pathMatch: "full" }, // Перенаправление на главную страницу
    { path: "**", redirectTo: "generation", pathMatch: "full" }, // Перенаправление на страницу 404
];
