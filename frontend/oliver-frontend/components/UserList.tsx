import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";

export default async function User() {
  const cookieStore = cookies();
  const supabase = createClient(cookieStore);
  const { data: users, error } = await supabase.from("users").select();

  if (error) {
    console.error("error fetching data:", error);
    return <div>Error fetching data!</div>
  }

  return (
    <section className="flex flex-col gap-10 w-full">
      <section className="flex  justify-center gap-10">
        {users.map((user) => (
          <span key={user.menu_id}>
            <ul>
              <li>
                <p>
                  <b>user ID</b>
                </p>
                <p>{user.user_id}</p>
              </li>
              <li>
                <p>
                  <b>name</b>
                </p>
                <p>{user.user_name}</p>
              </li>
              <li>
                <p>
                  <b>email</b>
                </p>
                <p>{user.user_email}</p>
              </li>
              <li>
                <p>
                  <b>phone</b>
                </p>
                <p>{user.user_phone}</p>
              </li>
              <li>
                <p>
                  <b>Birthday</b>
                </p>
                <p>{user.user_birthday}</p>
              </li>
              <li>
                <p>
                  <b>location</b>
                </p>
                <p>{user.location_id}</p>
              </li>
            </ul>
            <br />
          </span>
        ))}
      </section>
    </section>
  );
}