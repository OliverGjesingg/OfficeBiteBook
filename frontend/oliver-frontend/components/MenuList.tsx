import { useState, useEffect } from "react";
import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";
import Menu from "./Menu";
import ParticipateDay from "./ParticipateDay";
import ParticipateWeek from "./ParticipateWeek";
import AddGuestModal from "./AddGuestModal";
import AddGuest from "./AddGuest";
import ListMyGuests from "./ListMyGuests";
import lasagna from "../lasagne.jpg"
import Image from "next/image";
import Header from "./Header";

interface Props {
  userId?: any;
  guests: any[] | null;
  menuUser: any[] | null;
  menus: any[];
}

export default async function MenuList({userId, guests, menus, menuUser} : Props) {
  
    var currentDate = new Date();

    var startDate = new Date(currentDate.getFullYear(), 0, 1);

    var days = Math.floor((currentDate.getTime() - startDate.getTime()) /
    (24 * 60 * 60 * 1000)) + 1;
    var weekNumber  = Math.ceil(days / 7)+1;
 
// Display the calculated result       
// console.log(weekNumber);

  // const [currentDateNow, setCurrentDateNow] = useState(new Date());

  return (
    <section className="gap-10 w-full">
      <Header/>
      <div className="w-full">
        {/* <button>Previous</button> */}
      <h1 className="text-3xl w-28 mx-auto">Uge {weekNumber}</h1>
      {/* <button>Next</button> */}
      </div>
      <section className="flex justify-center gap-10 mt-5">        
        <div className="flex flex-col w-full md:w-3/4">
        <div className="flex ml-auto mr-auto flex-row w-3/4 justify-end">
        <AddGuestModal guests={guests || []} userId={{userId}}/>
        
        <ParticipateWeek menus={menus} weekNumber={weekNumber} userId={userId} menuUser={menuUser}/>
        </div>
        {menus.filter((menu) => { const menuDate = new Date(menu.menu_date); const menuWeekNumber = getWeekNumber(menuDate);return menuWeekNumber === weekNumber;}).length > 0 ? (
          menus
            .filter((menu) => {
              const menuDate = new Date(menu.menu_date);
              const menuWeekNumber = getWeekNumber(menuDate);
              return menuWeekNumber === weekNumber;
            })
            .sort((a, b) => new Date(a.menu_date).getTime() - new Date(b.menu_date).getTime())
            .map((menu) => (
              <div
                key={menu.menu_id}
                className="relative my-5 p-5 flex flex-row ml-auto mr-auto w-full lg:w-3/4 mx border-solid border-2 border-slate-100 rounded-md"
              >
                <Menu menu={menu} />
                <div className="absolute right-2">
                  <ParticipateDay menu={menu} userId={{ userId }} />
                </div>
              </div>
            ))
        ) : (
          <div className="w-full text-center mt-20">
            <p className="center text-xl">Der er ikke oprettet nogen menuer endnu</p>
          </div>
        )}

        
        </div>

      </section>
    </section>
  );
}
// Helper function to get the week number from a date
function getWeekNumber(date: Date): number {
  const startDate = new Date(date.getFullYear(), 0, 1);
  const days = Math.floor((date.getTime() - startDate.getTime()) / (24 * 60 * 60 * 1000));
  return Math.ceil(days / 7);
}
